using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    interface IRobot
    {
        // only public 
        // 인터페이스의 구성요소는 모두 public, 접근제한자 사용하지 말 것 

        //자동구현프로퍼터가 아님.
        //구현할 프로퍼티를 뜻함.
        int BatteryLevel { get; set; }
        void Charge ();
        // 인터페이스는 추상적이기 때문에 실행문이 없어야한다.
       /* {
        }*/
       
    }
}
