using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Windows.Forms;
namespace CpcDosCPlus
{
    public class CpcDosCPlusTextBox : CpcDosCPlusObjet
    {
        public CpcDosCPlusTextBox(string[] declaration) : base(declaration)
        {
        }

        public override string TypeObjet { get { return "textbox"; } }

        public string Handle
        {
            get
            {
                Attributes.TryGetValue(".handle", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".handle"))
                {
                    Attributes.Remove(".handle");
                }
                else
                {
                    Attributes[".handle"] = value;
                }
            }
        }
        public string BackColor
        {
            get
            {
                Attributes.TryGetValue(".BackColor", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".backcolor"))
                {
                    Attributes.Remove(".backcolor");
                }
                else
                {
                    Attributes[".backcolor"] = value;
                }
            }
        }


        public string Px
        {
            get
            {
                Attributes.TryGetValue(".px", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".px"))
                {
                    Attributes.Remove(".px");
                }
                else
                {
                    Attributes[".px"] = value;
                }
            }
        }
        public string Py
        {
            get
            {
                Attributes.TryGetValue(".py", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".py"))
                {
                    Attributes.Remove(".py");
                }
                else
                {
                    Attributes[".py"] = value;
                }
            }
        }
        public string SizeX
        {
            get
            {
                Attributes.TryGetValue(".sx", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".sx"))
                {
                    Attributes.Remove(".sx");
                }
                else
                {
                    Attributes[".sx"] = value;
                }
            }
        }
        public string SizeY
        {
            get
            {
                Attributes.TryGetValue(".sy", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".sy"))
                {
                    Attributes.Remove(".sy");
                }
                else
                {
                    Attributes[".sy"] = value;
                }
            }
        }
        public string Opacity
        {
            get
            {
                Attributes.TryGetValue(".Opacity", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".Opacity"))
                {
                    Attributes.Remove(".Opacity");
                }
                else
                {
                    Attributes[".Opacity"] = value;
                }
            }
        }
        public string Parameters
        {
            get
            {
                Attributes.TryGetValue(".Parameters", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".Parameters"))
                {
                    Attributes.Remove(".Parameters");
                }
                else
                {
                    Attributes[".Parameters"] = value;
                }
            }
        }
        public string Text
        {
            get
            {
                Attributes.TryGetValue(".text", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".text"))
                {
                    Attributes.Remove(".text");
                }
                else
                {
                    Attributes[".text"] = value;
                }
            }
        }
        public string Image
        {
            get
            {
                Attributes.TryGetValue(".image", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".image"))
                {
                    Attributes.Remove(".image");
                }
                else
                {
                    Attributes[".image"] = value;
                }
            }
        }
        public string Event
        {
            get
            {
                Attributes.TryGetValue(".event", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".event"))
                {
                    Attributes.Remove(".event");
                }
                else
                {
                    Attributes[".event"] = value;
                }
            }
        }

        public override UserControl CreateUC()
        {
            return new Controls.UCTextBox(this) as UserControl;

        }
    }
}

