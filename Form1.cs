using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assiment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            error_label.Text = "";
            Company.Load();
            foreach (Company company in Company.GetCompanies())
                companies_content.Rows.Add(company.GetId(), company.GetName(), company.GetAddress(),
                                           company.GetEmail(), company.GetPhone(), company.GetExpertise(),
                                           company.GetRating(), company.GetComments());
        }

        private void companies_content_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (companies_content.Rows.Count == 0) return;
            if (companies_content.Rows[e.RowIndex].Cells[0].Value == null) return;

            int ID = int.Parse(companies_content.Rows[e.RowIndex].Cells[0].Value.ToString());
            Company company = Company.GetCompany(ID);

            if (company == null) return;

            company_id_input.Text = company.GetId().ToString();
            company_name_input.Text = company.GetName();
            company_address_input.Text = company.GetAddress();
            company_email_input.Text = company.GetEmail();
            company_phone_input.Text = company.GetPhone();
            company_expertise_input.Text = company.GetExpertise();
            company_rating_input.Text = company.GetRating().ToString();
            company_comments_input.Text = company.GetComments();
            company_name_input.Enabled = true;
            company_address_input.Enabled = true;
            company_email_input.Enabled = true;
            company_phone_input.Enabled = true;
            company_expertise_input.Enabled = true;
            company_rating_input.Enabled = true;
            company_comments_input.Enabled = true;
            button_delete.Enabled = true;
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            const string CONTENT = "";
            button_delete.Enabled = false;
            company_id_input.Text = CONTENT;
            company_id_input.Enabled = false;
            company_name_input.Enabled = true;
            company_name_input.Text = CONTENT;
            company_name_input.Focus();
            company_address_input.Enabled = true;
            company_address_input.Text = CONTENT;
            company_email_input.Enabled = true;
            company_email_input.Text = CONTENT;
            company_phone_input.Enabled = true;
            company_phone_input.Text = CONTENT;
            company_expertise_input.Enabled = true;
            company_expertise_input.Text = CONTENT;
            company_rating_input.Enabled = true;
            company_rating_input.Text = CONTENT;
            company_comments_input.Enabled = true;
            company_comments_input.Text = CONTENT;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (company_id_input.Text == "")
            {
                if (!VeriyEmail(company_email_input.Text)) error_label.Text = "Your email address is invalid, please check and try saving again.";
                if (!VerifyPhone(company_phone_input.Text)) error_label.Text = "Your phone number is invalid, please check and try saving again.";

                if (VeriyEmail(company_email_input.Text) && VerifyPhone(company_phone_input.Text))
                {
                    Company company = new Company(company_name_input.Text, company_address_input.Text,
                                              company_email_input.Text, company_phone_input.Text,
                                              company_expertise_input.Text, Int16.Parse(company_rating_input.Text),
                                              company_comments_input.Text);
                    companies_content.Rows.Add(company.GetId(), company.GetName(), company.GetAddress(),
                                           company.GetEmail(), company.GetPhone(), company.GetExpertise(),
                                           company.GetRating(), company.GetComments());
                    company_id_input.Text = company.GetId().ToString();
                    if (error_label.Text != "") error_label.Text = "";
                    Company.Save();
                }
            }
            else
            {
                Company _company = Company.GetCompany(int.Parse(companies_content.CurrentRow.Cells[0].Value.ToString()));
                string[] _company_params = { _company.GetName(), _company.GetAddress(), _company.GetEmail(),
                                             _company.GetPhone(), _company.GetExpertise(), _company.GetRating().ToString(),
                                             _company.GetComments() };
                string[] _company_params_inp = { company_name_input.Text, company_address_input.Text, company_email_input.Text,
                                                 company_phone_input.Text, company_expertise_input.Text, company_rating_input.Text,
                                                 company_comments_input.Text };
                bool identical = true;

                for (int i = 0; i < _company_params.Length; i++)
                    if (_company_params[i] != _company_params_inp[i])
                    {
                        identical = false;
                        break;
                    }

                if (!identical)
                {
                    if (!VeriyEmail(company_email_input.Text)) error_label.Text = "Your email address is invalid, please check and try saving again.";
                    if (!VerifyPhone(company_phone_input.Text)) error_label.Text = "Your phone number is invalid, please check and try saving again.";
                    try
                    {
                        if (!VerifyRating(int.Parse(company_rating_input.Text))) error_label.Text = "Your rating is invalid, please check and try saving again.";

                        if (VeriyEmail(company_email_input.Text) && VerifyPhone(company_phone_input.Text) && VerifyRating(int.Parse(company_rating_input.Text)))
                        {
                            Company company = Company.GetCompany(int.Parse(company_id_input.Text));
                            company.name = company_name_input.Text;
                            company.address = company_address_input.Text;
                            company.email = company_email_input.Text;
                            company.phone = company_phone_input.Text;
                            company.expertise = company_expertise_input.Text;
                            company.rating = Int16.Parse(company_rating_input.Text);
                            company.comments = company_comments_input.Text;
                            companies_content.CurrentRow.Cells[1].Value = company.name;
                            companies_content.CurrentRow.Cells[2].Value = company.address;
                            companies_content.CurrentRow.Cells[3].Value = company.email;
                            companies_content.CurrentRow.Cells[4].Value = company.phone;
                            companies_content.CurrentRow.Cells[5].Value = company.expertise;
                            companies_content.CurrentRow.Cells[6].Value = company.rating;
                            companies_content.CurrentRow.Cells[7].Value = company.comments;
                            if (error_label.Text != "") error_label.Text = "";
                            Company.Save();
                        }
                    }
                    catch (Exception exc)
                    {
                        error_label.Text = exc.Message;
                    }
                }
                else error_label.Text = "You haven't changed anything.";
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Company.Delete(int.Parse(companies_content.CurrentRow.Cells[0].Value.ToString()));
            Company.Save();
            companies_content.Rows.RemoveAt(companies_content.CurrentRow.Index);
        }

        private void button_with_same_name_expertise_Click(object sender, EventArgs e)
        {
            if (Validation('n'))
                foreach (DataGridViewRow Row in companies_content.Rows)
                {
                    if (Row.Cells[1].Value.ToString().Contains(search_input.Text) ||
                        Row.Cells[5].Value.ToString().Contains(search_input.Text)) Row.Visible = true;
                    else Row.Visible = false;
                }
        }

        private void button_bigger_raiting_Click(object sender, EventArgs e)
        {
            if (Validation())
                foreach (DataGridViewRow Row in companies_content.Rows)
                {
                    if (int.Parse(Row.Cells[6].Value.ToString()) <
                        int.Parse(search_input.Text)) Row.Visible = false;
                    else Row.Visible = true;
                }
        }

        private void button_less_raiting_Click(object sender, EventArgs e)
        {
            if (Validation())
                foreach (DataGridViewRow Row in companies_content.Rows)
                {
                    if (int.Parse(Row.Cells[6].Value.ToString()) >
                        int.Parse(search_input.Text)) Row.Visible = false;
                    else Row.Visible = true;
                }
        }

        private void button_equal_raiting_Click(object sender, EventArgs e)
        {
            if (Validation())
                foreach (DataGridViewRow Row in companies_content.Rows)
                {
                    if (int.Parse(Row.Cells[6].Value.ToString()) !=
                        int.Parse(search_input.Text)) Row.Visible = false;
                    else Row.Visible = true;
                }
        }

        private void search_input_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in companies_content.Rows) Row.Visible = true;
            error_label.Text = "";
        }

        private void company_comments_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Enter && e.KeyChar == (char)Keys.RShiftKey)
                e.Handled = true;
        }

        private bool VeriyEmail(string email)
        {
            char[] symvols = { '!', '#', '$', '%', '^', '&', '*', '¹', '"', '`', '~', ';', ':', '/', '\\', '|', ',', '<', '>', ' ', '@' };
            if (email == null || !email.Contains('@')) return false;

            string[] e_parts = email.Split('@');

            for (int i = 0; i < 2; i++)
                foreach (char symvol in symvols)
                    if (e_parts[i].Contains(symvol)) return false;

            if (!e_parts[1].Contains('.')) return false;

            string[] e_domen_parts = e_parts[1].Split(".");

            if (e_domen_parts[1].Length == 0) return false;

            return true;
        }

        private bool VerifyPhone(string phone)
        {
            if (phone == null || !phone.Contains(' ')) return false;
            if (!phone.Replace(" ", "").All(c => char.IsDigit(c))) return false;

            string[] p_parts = phone.Split(' ');

            if (p_parts.Length >= 5 || p_parts.Length < 4) return false;
            if (p_parts[3] == "") return false;

            return true;
        }

        private bool VerifyRating(int rating)
        {
            if (rating == null) return false;

            if (rating < 0 || rating > 10) return false;

            return true;
        }

        private bool Validation(char choice = 'd')
        {
            if (search_input.Text == null || search_input.Text == "")
            { error_label.Text = "You didn't write anything in the search."; return false; }

            if (choice == 'd') if (!search_input.Text.All(c => char.IsDigit(c)))
                { error_label.Text = "You didn't write a number."; return false; }

            return true;
        }
    }
}