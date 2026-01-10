namespace SingletonPattern{
    public class Master{
        public string? name {get; set;}
        public string? title {get; set;}
        
        public Master(){
            this.name = null;
            this.title = null;
        }

        public Master(string name, string title)
        {
            this.name = name;
            this.title = title;
        }

        public string MasterInfo(){
            return $"{this.name} {this.title}";
        }
    }
}
