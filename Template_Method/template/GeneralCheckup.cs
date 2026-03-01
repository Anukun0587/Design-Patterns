namespace Template_Method.template
{
    public class GeneralCheckup : MedicalExamination
    {
        private bool hasChronicDisease;

        public GeneralCheckup(string patientName, int patientAge, bool hasChronicDisease)
            : base(patientName, patientAge)
        {
            this.hasChronicDisease = hasChronicDisease;
        }

        public override string examinationType()
        {
            return "ตรวจสุขภาพทั่วไป (General Checkup)";
        }

        public override void examine()
        {
            Console.WriteLine("[3] ตรวจร่างกาย : วัดความดัน, ชีพจร, อุณหภูมิ, ฟังเสียงปอดและหัวใจ, เจาะเลือด CBC และตรวจปัสสาวะ");
        }

        public override void diagnose()
        {
            Console.WriteLine("[4] วินิจฉัย : ประเมินผลเลือดและอาการโดยรวม");

            if (hasChronicDisease)
                Console.WriteLine(" : พบความเสี่ยงโรคเรื้อรัง ควรติดตามอาการ");
            else
                Console.WriteLine(" : ผลตรวจอยู่ในเกณฑ์ปกติ");
        }

        public override void prescribe()
        {
            Console.WriteLine("[5] สั่งยา : วิตามินบำรุงร่างกายและคำแนะนำด้านสุขภาพ");
        }

        public override bool needsReferral()
        {
            return hasChronicDisease;
        }

        public override void refer()
        {
            Console.WriteLine("[+] ส่งตัว : ส่งพบอายุรแพทย์เพื่อตรวจเพิ่มเติม");
        }

        public override bool needsFollowUp()
        {
            return true;
        }

        public override void makeAppointment()
        {
            Console.WriteLine("[+] นัดหมาย : นัดตรวจสุขภาพประจำปีครั้งถัดไปใน 12 เดือน");
        }
    }
}