using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulationM.Sys
{

    class Sys
    {
        Node Node1;
        Node Node2;
        IStream input;
        Orbit Orbit;
  
        public Sys(IStream input, double mu1,double mu2,double sigma)
        {
            this.input = input;
            Node1 = new Node(mu1);
            Node2 = new Node(mu2);
            Orbit = new Orbit(sigma);
        }

        public void Process()
        {   
            Claim inputClaim = input.Send();
            if (inputClaim != null)
            {
                inputClaim = Node1.Apply(inputClaim);//занят  ли
                if (inputClaim != null)//занят, не забрал
                {
                    Orbit.Push(inputClaim);//на орбиту
                }
            }
            inputClaim = Orbit.Send();//пришло ли время заявки с орбиты попробовать снова встать на прибор?
            if (inputClaim != null)//пришло
            {
                inputClaim = Node1.Apply(inputClaim);//занят ли
                if (inputClaim != null)//занят
                {
                    Orbit.Push(inputClaim);
                }
            }
            inputClaim = Node1.Serve();//обслуживает, если есть, что обслуживать
            if(inputClaim != null)//если есть заявка, только что обслужившаяся на первом приборе
            {
                inputClaim = Node2.Apply(inputClaim);//свободен ли второй прибор?
                if (inputClaim != null)//занят, выплюнул заявку
                {
                    Orbit.Push(inputClaim);//заявка ушла на орбиту
                }
            }
            Node2.Serve();//обслуживание на втором узле
        }

    }
}
