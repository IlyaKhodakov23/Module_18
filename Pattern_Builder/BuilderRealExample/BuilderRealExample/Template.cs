using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderRealExample
{
    /// <summary>
    /// Шаблон письма
    /// </summary>



    class Template
    {
        // заголовок
        public Header Header { get; set; }

        // тело
        public Body Body { get; set; }

        // футер или нижний колонтитул
        public Footer Footer { get; set; }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            if (Header != null)
                text.Append(Header.Text + "\n");

            if (Body != null)
                text.Append($"{Body.Text} \n");

            if (Footer != null)
                text.Append($"{Footer.Text} \n");

            return text.ToString();
        }
    }
}
