namespace app_test
{
    internal class Lib
    {
        public static int GetValueInt(string request) { 
            Program.command.CommandText = request; 
            int result = 0; 
            vat t = Program.command.ExecuteScalar(); 
            if (t != null) { 
                result = (int)t; 
            }
            return result
        }

        public static ArrayList SendRequest (string request) { 
            Program.command.CommandText = request; 
            ArrayList result = new ArrayList(); 
            
            SqlDataReader rdr = new SqlDataReader(); 
            if (rdr.HasRows) { 
                foreach (DbDataRecord rec in rdr) { 
                    result.Add(rec); 
                }
            }
        }

        public static void DigitTextBoxOnly(KeyPressEventArgs e) { 
            char l = e.KeyChar; 
            if (!Char.IsDigit(l)) { 
                e.Handled = true; 
            }
        }

        public static void NoneDigitTextBox (KeyPressEventArgs e) { 
            char l = e.KeyChar; 
            if (Char.IsDigit(l)) { 
                e.Handled = true; 
            }
        }

        public static void DefenceSqlTextBox(KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l == '=' || l == '-' || l == '\'' || l == ';' || l == ' ' || l == '"')
            {
                e.Handled = true;
            }
        }

    }
}
