using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfDbCon
{
    // 참고: "리팩터링" 메뉴에서 "이름 바꾸기" 명령을 사용하여 코드, svc 및 config 파일에서 클래스 이름 "Service1"을 변경할 수 있습니다.
    // 참고: 이 서비스를 테스트하기 위해 WCF 테스트 클라이언트를 시작하려면 솔루션 탐색기에서Service1.svc나 Service1.svc.cs를 선택하고 디버깅을 시작하십시오.
    public class Service1 : IService1
    {
        public static int SUM = 0;
        public static int SUB = 1;
        public static int MULTI = 2;
        public static int DIVI = 3;
        public int GetCalculate(int input1, int input2, int calculType)
        {
            int result = 0;
            switch (calculType) 
            {
                case CalculType.Plus:
                    result = input1 + input2;
                    break;
                case CalculType.Minus:
                    result = input1 - input2;
                    break;
                case CalculType.Multi:
                    result = input1 * input2;
                    break;
                default:
                    result = input1 / input2;
                    break;
            }
            return result;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
