using InfaTechnologies.Core;
using InfaTechnologies.Core.Generators;
using InfaTechnologies.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfaTechnologies
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            //Remove()
            //Add()
            //Exists()
            //Update()
            //GetById()
            //GetAll()

            //bele bir kart var mi?
            // kart varsa  onu istifade olunmush qeyd et

            // melumatlari update ele

            // yeni istifadechi yarat

            Card card = new Card()
            {
                Number = txbx_card_number.Text
            };

            using (Database db = new InMemoryDatabase())
            {
                db.Cards.Add(new Card
                {
                    Id = 1,
                    Number = "12345",
                    IsUsed = false,
                    CurrencyType = CurrencyType.USD,
                    Balance = 45,
                    AddedDate = DateTime.Now
                });

                Card existsCard = db.Cards.Exists(card);
                if (existsCard != null)
                {
                    string n = new NameGenerator().Generate();
                    AppUser appuser = new AppUser()
                    {
                        Email = new EmailGenerator().Generate(),
                        MobileNumber = "",
                        Name = n,
                        Password =n,
                        RoleType = RoleType.User,
                        Balance = existsCard.Balance
                    };

                    AppUser addeduser = db.Users.Add(appuser);

                    if (addeduser != null)
                    {
                        existsCard.ActivatedBy = addeduser;
                        existsCard.ActivatedById = addeduser.Id;
                        existsCard.IsUsed = true;
                        existsCard.ActivatedDate = DateTime.Now;
                        db.Cards.Update(existsCard);
                    }
                }
            }

        }
    }
}
