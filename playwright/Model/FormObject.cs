namespace playwright.Model
{
    public class FormObject
    {
        public string TxtboxUser { get; set; }
        public string TxtboxPassword { get; set; }
        public bool CheckboxWriteCredentials { get; set; }
        public string TxtboxJob { get; set; }

        public FormObject(dynamic formObject)
        {
            this.TxtboxUser = formObject.txtboxUser;
            this.TxtboxPassword = formObject.txtboxPassword;
            this.CheckboxWriteCredentials = formObject.checkboxWriteCredentials;
            this.TxtboxJob = formObject.txtboxJob;
        }
    }
}
