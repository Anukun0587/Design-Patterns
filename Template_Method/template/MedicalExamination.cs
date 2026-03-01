namespace Template_Method.template
{
    public abstract class MedicalExamination
    {
        private string patientName { get; set; }
        private int patientAge { get; set; }

        public MedicalExamination(string patientName, int patientAge)
        {
            this.patientName = patientName;
            this.patientAge = patientAge;
        }

        public void register()
        {
            Console.WriteLine("[1] ลงทะเบียน  : บันทึกข้อมูลผู้ป่วยและออกบัตรคิว");
        }

        public void takeHistory()
        {
            Console.WriteLine("[2] ซักประวัติ : อาการ, ประวัติแพ้ยา, โรคประจำตัว");
        }

        public abstract string examinationType();

        public abstract void examine();

        public abstract void diagnose();

        public abstract void prescribe();

        public virtual bool needsReferral()
        {
            return false;
        }

        public virtual bool needsFollowUp()
        {
            return false;
        }

        public virtual void refer(){}

        public virtual void makeAppointment(){}

        public void doExamination()
        {
            Console.WriteLine($"{examinationType()}");
            Console.WriteLine($"ผู้ป่วย: {patientName} | อายุ: {patientAge} ปี");

            register();
            takeHistory();
            examine();
            diagnose();
            prescribe();

            if (needsReferral())
            {
                refer();
            }

            if (needsFollowUp())
            {
                makeAppointment();
            }

            Console.WriteLine($"\nการตรวจเสร็จสิ้น — ขอให้หายไว!\n");
        }
    }
}