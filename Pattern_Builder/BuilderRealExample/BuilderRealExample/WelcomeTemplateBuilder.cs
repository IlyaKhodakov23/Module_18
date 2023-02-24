using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderRealExample
{
    ///Теперь конкретные шаблонизаторы-строители.  <summary>
    /// Теперь конкретные шаблонизаторы-строители. 
    /// </summary>
    ///Их будет два: для приветственной рассылки после регистрации и для рассылки информации по заказу.
    /// <summary>
    /// Строитель для создания приветственной рассылки
    /// </summary>
    class WelcomeTemplateBuilder : TemplateBuilder
    {
        public override void BuildHeader()
        {
            Template.Header = new Header { Text = "Здравствуйте!" };
        }

        public override void BuildBody()
        {
            Template.Body = new Body { Text = "Спасибо за регистрацию в нашем приложении" };
        }

        public override void BuildFooter()
        {
            // не используется
        }
    }
}
