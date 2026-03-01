using Template_Method.template;

namespace Template_Method
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("โรงพยาบาล Template General Hospital");

            MedicalExamination patients1 = new GeneralCheckup("สมชาย ใจดี",  45, hasChronicDisease: true);
            MedicalExamination patients2 = new GeneralCheckup("สมหญิง สวยงาม", 30, hasChronicDisease: false);
            MedicalExamination patients3 = new DentalExam("มาลี รักสวย", 30, needsFilling: true);
            MedicalExamination patients4 = new DentalExam("มานะ ขยันขันแข็ง", 25, needsFilling: false);

            Console.WriteLine("\n── เริ่มตรวจสุขภาพทั่วไป (General Checkup) ──");
            patients1.doExamination();
            patients2.doExamination();

            Console.WriteLine("\n── เริ่มตรวจสุขภาพช่องปาก (Dental Exam) ──");
            patients3.doExamination();
            patients4.doExamination();
        }
    }
}