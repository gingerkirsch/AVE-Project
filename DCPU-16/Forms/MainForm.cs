using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DCPU_16.Forms;
using DCPU_16.Properties;
using System.Text.RegularExpressions;

namespace DCPU_16
{
    public partial class Form1 : Form
    {
        public readonly int ToolBoxWidth = 200;
        public Executor E;
        public ExecuteForm D = new ExecuteForm();
        private const string Filter = "Program files | *.dasm16";
        private const string Capiton = "DCPU-16";
        private readonly Code _code;
        private const int CodeSize = 99;
        private readonly HelpForm _help = new HelpForm();
        public static bool HasDump { get; set; }

        private Regex ADDR_PATTERN = new Regex("[0-9]+");
        private String ADDR_WARNING = "Can be natural number or zero";
        private Regex VALUE_PATTERN = new Regex("\\b(?=\\w)[0-9]{1,2}\\b(?!\\w)");
        private String VALUE_WARNING = "Operand can be value (0-31) or register (ABCXYZIJ)";
        private String REG_WARNING = "Operand can be register only (ABCXYZIJ)";
        private Regex REG_PATTERN = new Regex("\\b(?=\\w)[abcxyzijABCXYZIJ]\\b(?!\\w)");

        public Form1()
        {
            InitializeComponent();

            WorkSpace.Panel2.Visible = false;
            WorkSpace.SplitterDistance = Width;

            _code = new Code(CodeSize);

            try
            {
                foreach (var command in Decryptor.Commands)
                {
                    CommandBox.Items.Add(command);
                }
                foreach (var command in Decryptor.NonBasicCommands) 
                {
                    CommandBox.Items.Add(command);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            CommandBox.SelectedIndex = 0;

            D.Show();
            HasDump = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var m = MessageBox.Show(Resources.ExitString, Capiton, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (m == DialogResult.Yes)
            {
                Close();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.Items.Count > 0)
            {
                var m = MessageBox.Show(Resources.SaveString, Capiton, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (m == DialogResult.Yes)
                {
                    Save();
                }
            }

            Program.Items.Clear();
            CommandBox.SelectedIndex = 0;
            WorkSpace.Panel2.Visible = true;
            WorkSpace.SplitterDistance = Width - ToolBoxWidth;
        }

        private void Save()
        {
                    
            var s = new SaveFileDialog { Filter = Filter };
            if(s.ShowDialog() == DialogResult.OK)
            {
                string[] hexaArray = new string[_code.ProgramArray.Length];
                for (int i = 0; i < _code.ProgramArray.Length; i++) {
                    hexaArray[i] = Convert.ToString(_code.ProgramArray[i], 16);
                
                }

                IO.Write(s.FileName, hexaArray);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (!WorkSpace.Panel2.Visible)
            {
                WorkSpace.SplitterDistance = Width;
                return;
            }

            if (Width > ToolBoxWidth)
            {
                WorkSpace.SplitterDistance = Width - ToolBoxWidth;
            }
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            WorkSpace.Panel2.Visible = false;
            WorkSpace.SplitterDistance = Width;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var o = new OpenFileDialog { Filter = Filter };
            if (o.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            _code.ProgramArray = IO.Read(o.FileName, 99);
            for (var i = 0; i < _code.MaxLength; i++)
            {
                WriteInstruction(_code.ProgramArray[i], i);
            }
        }

        private void CommandBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //Console.WriteLine("does this even gets called? " + CommandBox.SelectedIndex);
            if (CommandBox.SelectedIndex > 26 && CommandBox.SelectedIndex < 34)
            {
                OperandAddress2.Enabled = false;
                label5.Enabled = false; // im calling :/
            }
            else {
                OperandAddress2.Enabled = true;
                label5.Enabled = true;
            
            }

        }

        private void WriteInstruction(int value, int index)
        {
            if (value > Processor.MaxValue || value < Processor.MinValue)
            {
                return;
            }

            if (Program.Items.Count > index)
            {
                Program.Items.RemoveAt(index);
            }

            string instruction;
            Console.WriteLine("value " );
           /* var command = 0;
            
            if (value < 20)
            {
                command = value; 
            }
            else{ */
            var basicOrNon = value & 0x001f;

            if (basicOrNon != 0)
            {  
            //basic
            var command = value & 0x001f;
            //}
            Decryptor.Commands.TryGetValue(command, out instruction);
            Program.Items.Insert(index, String.Format("{0:00}:\t{1}\t{2}{3}\t[{4}]", index, instruction, OperandAddress.Text.ToUpper(), 
                ","+ OperandAddress2.Text.ToUpper(), Convert.ToString(value, 16)));
            }
            else{
                var command = value & 0x03e0;
                command >>= 5;

                Decryptor.NonBasicCommands.TryGetValue(command, out instruction);
                Program.Items.Insert(index, String.Format("{0:00}:\t{1}\t{2}{3}\t[{4}]", index, instruction, OperandAddress.Text.ToUpper(),
                    "," + OperandAddress2.Text.ToUpper(), Convert.ToString(value, 16)));
            
            
            
            }
        }

        private void Run_Click(object sender, EventArgs e)
        {
            E = new Executor { P = new Processor(100) };

            if (!E.P.LoadMemory(_code.ProgramArray))
            {
                return;
            }

            D.UpdateDamp(E.GetDump(0, 30));
            E.Execute();
            D.UpdateOutput(Executor.Output.ToString());
            //this prints ram
            D.UpdateDamp(E.GetDump(0,10));
            //this prints registers and overrides the last
            D.UpdateRegisters(E.P.RegToString());
        }

        private void toolBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkSpace.Panel2.Visible = true;
            WorkSpace.SplitterDistance = Width - ToolBoxWidth;
        }

        private void outputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HasDump)
            {
                D.Close();
                return;
            }

            D = new ExecuteForm();
            D.Show();
            if (E != null)
            {
                D.UpdateDamp(E.GetDump(0, 30));
            }
        }

        private void AddCommand_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (!ADDR_PATTERN.IsMatch(CommandAddress.Text))
                {
                    MessageBox.Show(ADDR_WARNING);
                    return;
                }
                var index = Int32.Parse(CommandAddress.Text);
                int command;
                ushort word = 0x0000;
                
                int first_operand;
                int second_operand;
              /*  int command;
                Console.WriteLine(CommandBox.SelectedIndex);
                
                Decryptor.Instructions.TryGetValue(CommandBox.SelectedIndex, out command);
                command++;
                Console.WriteLine(command);
                ushort word = 0x0000;
                word = (ushort)(0x0000 | command);
                Console.WriteLine("a " + Convert.ToString(word, 2));
                int first_operand;
                int second_operand;*/

                if (CommandBox.SelectedIndex > 26){
                    if (REG_PATTERN.IsMatch(OperandAddress.Text)) 
                    {
                       // Console.WriteLine("CommandBox.SelectedIndex " + CommandBox.SelectedIndex);
                        Decryptor.NonBasicInstructions.TryGetValue(CommandBox.SelectedIndex + 1, out command);
                        //command++;
                        Console.WriteLine("command non basic " + Convert.ToString(command, 2));
                
                        word = (ushort)(0x0000 | command);
                       // Console.WriteLine("non basic code " + Convert.ToString(word, 2));
                

                        Decryptor.Registers.TryGetValue(OperandAddress.Text.ToString().ToUpper(), out first_operand);
                        word |= (ushort)(first_operand << 10);
                        //Console.WriteLine(first_operand);
                    } else {
                        MessageBox.Show(REG_WARNING);
                        return;
                    }
                } else {
                    Decryptor.Instructions.TryGetValue(CommandBox.SelectedIndex, out command);
                    command++;
                    word = (ushort)(0x0000 | command);
                    if (REG_PATTERN.IsMatch(OperandAddress.Text))
                    {
                        Decryptor.Registers.TryGetValue(OperandAddress.Text.ToString().ToUpper(), out first_operand);
                        first_operand <<= 5;
                       // Console.WriteLine("first_operand " + first_operand);
                        word |= (ushort)first_operand;
                       // Console.WriteLine("word " + word);
                    }
                    else if (VALUE_PATTERN.IsMatch(OperandAddress.Text))
                    {  //add <32
                        //Console.WriteLine("VALUE_PATTERN.IsMatch");
                        first_operand = Int32.Parse(OperandAddress.Text);
                        ///Console.WriteLine(first_operand);
                    }
                    else
                    {
                        MessageBox.Show(VALUE_WARNING);
                        return;
                    }

                    if (REG_PATTERN.IsMatch(OperandAddress2.Text))
                    {

                        Decryptor.Registers.TryGetValue(OperandAddress2.Text.ToString().ToUpper(), out second_operand);
                        second_operand = (ushort)(second_operand << 10);
                        Console.WriteLine("second_operand " + second_operand); 

                        word = (ushort)(word | second_operand);
                    }
                    else
                    {
                        if (VALUE_PATTERN.IsMatch(OperandAddress2.Text))
                        {
                            Console.WriteLine("VALUE_PATTERN.IsMatch");
                            second_operand = Int32.Parse(OperandAddress2.Text);

                            Console.WriteLine("second_operand-> " + second_operand);
                            word = (ushort)((0x8400 + (second_operand << 10)) | word);
                            Console.WriteLine("WORD " + Convert.ToString(word, 2));

                        }
                        else
                        {
                            MessageBox.Show(VALUE_WARNING);
                            return;
                        }
                    }


                }


                //first_operand = (ushort)(first_operand << 5);
                //word = (ushort)(word | first_operand);
                
                //  second_operand = (ushort)(second_operand << 10);
                // word = (ushort)(word | second_operand);

                Console.WriteLine("word " + Convert.ToString(word, 2));
                //ushort b = (ushort)(0x0084 + (operand << 2));


                //var result = command*100 + operand;
                ushort result = word;
                Console.WriteLine(Convert.ToString(word, 2));
                if (_code.Add(index, result))
                {
                    Console.WriteLine(Convert.ToString(word, 2));
                    Console.WriteLine(result);
                    Console.WriteLine(Convert.ToString(word, 16));

                    Console.WriteLine(index);
                    Console.WriteLine("dentro do if");
                    WriteInstruction(result, index);
                }   
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void AddData_Click(object sender, EventArgs e)
        {
            try
            {
                var index = Int32.Parse(DataAdress.Text);
                var result = Int32.Parse(DataValue.Text);

                if (_code.Add(index, (ushort)result))
                {
                    WriteInstruction(result, index);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void ClearCell_Click(object sender, EventArgs e)
        {
            try
            {
                var index = Int32.Parse(CellAddress.Text);
                if (_code.Add(index, 0))
               {
                    WriteInstruction(0, index);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Run.Enabled = true;
            File.Enabled = true;
            WorkSpace.Panel2.Enabled = true;
            Stop.Enabled = false;
            doStepToolStripMenuItem.Enabled = false;
            startDebuggingToolStripMenuItem.Enabled = false;
        }

        private void startDebuggingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Run.Enabled = false;
            File.Enabled = false;
            WorkSpace.Panel2.Enabled = false;
            doStepToolStripMenuItem.Enabled = true;
            startDebuggingToolStripMenuItem.Enabled = true;
            Stop.Enabled = true;

            E = new Executor { P = new Processor(100) };
            if (!E.P.LoadMemory(_code.ProgramArray))
            {
                return;
            }

            D.UpdateDamp(E.GetDump(0, 30));
            E.Prepearing();
            D.UpdateOutput(Executor.Output.ToString());
        }

        private void doStepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (E.DoStep())
            {
                D.UpdateDamp(E.GetDump(0, 30));
                D.UpdateOutput(Executor.Output.ToString());
                Program.SelectedIndex = E.P.PC;
            }
            else
            {
                // E.CheckErrors();
                D.UpdateOutput(Executor.Output.ToString());

                Run.Enabled = true;
                File.Enabled = true;
                WorkSpace.Panel2.Enabled = true;
                Stop.Enabled = false;
                doStepToolStripMenuItem.Enabled = false;
                startDebuggingToolStripMenuItem.Enabled = false;
            }
        }

        private void commandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _help.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.AboutString, Capiton);
        }

        private void Program_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAdress.Text = Program.SelectedIndex.ToString();
            CommandAddress.Text = Program.SelectedIndex.ToString();
            CellAddress.Text = Program.SelectedIndex.ToString();
        }
        private void keyinput(object sender, KeyEventArgs e)
        {

            Console.WriteLine("I'm in keyinput! " + e.KeyValue);
            if (Processor.keyboardFlag)
            {
                Console.WriteLine("--------keyboard flag set to true-----------");
                Console.WriteLine("key value at moment ___ "+GetKeyValue(e.KeyValue));              
                Executor.lastkeypressed = GetKeyValue(e.KeyValue);
                Executor.handles[0].Set();
            }
            return;
        }

        private int GetKeyValue(int keyValue)
        {
            if (keyValue >= 48 && keyValue <= 57)
            {
                return keyValue - 48;
            }
            else if (keyValue >= 96 && keyValue <= 105)
            {
                return keyValue - 96;
            }
            else
            {
                return -1; // Not a number... do whatever...
            }
        }
    }
}
