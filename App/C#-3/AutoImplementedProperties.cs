namespace App
{
    public class AutoImplementedProperties
    {
        private string nameOld;
        public string NameOld
        {
            get { return nameOld; }
            set { nameOld = value; }
        } 

        public string NameNew { get; set; }
    }
}
