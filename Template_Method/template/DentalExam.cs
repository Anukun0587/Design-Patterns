namespace Template_Method.template
{
    public class DentalExam : MedicalExamination
    {
        private bool needsFilling;

        public DentalExam(string name, int age, bool needsFilling = false)
            : base(name, age)
        {
            this.needsFilling = needsFilling;
        }

        public override string examinationType()
        {
            return "ตรวจสุขภาพช่องปาก (Dental Exam)";
        }

        public override void examine()
        {
            Console.WriteLine("[3] ตรวจช่องปาก: ตรวจฟัน เหงือก ลิ้น และเยื่อบุช่องปาก, เอกซเรย์ฟันเพื่อดูรากและกระดูกรองรับ");
        }

        public override void diagnose()
        {
            if(needsFilling)
            {
                Console.WriteLine("[4] วินิจฉัย : พบฟันผุ ต้องอุดฟัน");
            }
            else
            {
                Console.WriteLine("[4] วินิจฉัย : ฟันและเหงือกแข็งแรงดี แนะนำขูดหินปูน");
            }
        }

        public override void prescribe()
        {
            if (needsFilling)
            {
                Console.WriteLine("[5] รักษา : ฉีดยาชาและอุดฟันด้วยคอมโพสิตเรซิน");
            }
            else
            {
                Console.WriteLine("[5] รักษา : ขูดหินปูนและขัดฟัน พร้อมเคลือบฟลูออไรด์");
            }
        }

        public override bool needsFollowUp()
        {
            return needsFilling;
        }

        public override void makeAppointment()
        {
            Console.WriteLine("[+] นัดหมาย : นัดอุดฟันครั้งถัดไปใน 1 สัปดาห์");
        }
    }
}