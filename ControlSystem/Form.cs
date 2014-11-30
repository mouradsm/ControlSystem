using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSystem
{
    public class Form : System.Windows.Forms.Form
    {
        public static void ClearForm(System.Windows.Forms.Control parent)
        {
            foreach (System.Windows.Forms.Control ctrControl in parent.Controls)
            {
                //Loop through all controls 
                if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.TextBox)))
                {
                    //Check to see if it's a textbox 
                    ((System.Windows.Forms.TextBox)ctrControl).Text = string.Empty;
                    //If it is then set the text to String.Empty (empty textbox) 
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RichTextBox)))
                {
                    //If its a RichTextBox clear the text
                    ((System.Windows.Forms.RichTextBox)ctrControl).Text = string.Empty;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.ComboBox)))
                {
                    //Next check if it's a dropdown list 
                    ((System.Windows.Forms.ComboBox)ctrControl).SelectedIndex = -1;
                    //If it is then set its SelectedIndex to 0 
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.CheckBox)))
                {
                    //Next uncheck all checkboxes
                    ((System.Windows.Forms.CheckBox)ctrControl).Checked = false;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RadioButton)))
                {
                    //Unselect all RadioButtons
                    ((System.Windows.Forms.RadioButton)ctrControl).Checked = false;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.MaskedTextBox)))
                {
                    ((System.Windows.Forms.MaskedTextBox)ctrControl).Clear();
                }
                if (ctrControl.Controls.Count > 0)
                {
                    //Call itself to get all other controls in other containers 
                    ClearForm(ctrControl);
                }
            }


        }

        public static Boolean validarCampo(System.Windows.Forms.Control parent)
        {

            bool validado = true;


            //Loop through all controls 
            foreach (System.Windows.Forms.Control ctrControl in parent.Controls)
            {
                if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.TextBox)))
                {
                    if (((System.Windows.Forms.TextBox)ctrControl).Text == string.Empty)
                        validado = false;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RichTextBox)))
                {
                    validado = true;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.ComboBox)))
                {
                    if (((System.Windows.Forms.ComboBox)ctrControl).SelectedIndex == null)
                        validado = false;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.CheckBox)))
                {
                    if (((System.Windows.Forms.CheckBox)ctrControl).Checked == false)
                        validado = false;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RadioButton)))
                {
                    //Unselect all RadioButtons
                    validado = true;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.MaskedTextBox)))
                {
                    //valida telefone
                    if (((System.Windows.Forms.MaskedTextBox)ctrControl).Text == string.Empty)
                        validado = false;
                    if (((System.Windows.Forms.MaskedTextBox)ctrControl).Text == "  /  /")
                        validado = false;
                }
            }
            return validado;
        }

        public static Boolean validarCampos(System.Windows.Forms.Control ctrControl)
        {

            bool validado = true;


            //Loop through all controls 
            if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.TextBox)))
            {
                if (((System.Windows.Forms.TextBox)ctrControl).Text == string.Empty)
                    validado = false;
            }
            else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RichTextBox)))
            {
                validado = true;
            }
            else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.ComboBox)))
            {
                if (((System.Windows.Forms.ComboBox)ctrControl).SelectedIndex == null)
                    validado = false;
            }
            else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.CheckBox)))
            {
                if (((System.Windows.Forms.CheckBox)ctrControl).Checked == false)
                    validado = false;
            }
            else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RadioButton)))
            {
                //Unselect all RadioButtons
                validado = true;
            }
            else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.MaskedTextBox)))
            {
                //valida telefone
                if (((System.Windows.Forms.MaskedTextBox)ctrControl).Text == string.Empty)
                    validado = false;
                if (((System.Windows.Forms.MaskedTextBox)ctrControl).Text == "  /  /")
                    validado = false;
            }

            return validado;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form
            // 
            this.ClientSize = new System.Drawing.Size(284, 258);
            this.Name = "Form";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);

        }

        private void Form_Load(object sender, EventArgs e)
        {

        }
    }
}
