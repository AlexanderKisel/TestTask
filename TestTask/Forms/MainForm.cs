using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TestTask.Models;

namespace TestTask
{
    public partial class MainForm : Form
    {
        DataTable dt = new DataTable();

        public MainForm()
        {
            InitializeComponent();

            personDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            personDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dt.Columns.Add("ФИО");
            dt.Columns.Add("Статус");
            dt.Columns.Add("Должность");
            dt.Columns.Add("Отдел");
            dt.Columns.Add("Дата приема");
            dt.Columns.Add("Дата увольнения");

            UpdateDgvPerson();
            LoadFilterData();
        }

        //Кнопка для применения фильтрации
        private void applyTxtBox_Click(object sender, System.EventArgs e)
        {
            //Создаю общую строку для фильтрации, чтобы не писать код для кажого ComboBox отдельно
            if (dt.Rows.Count == 0) return;

            string filterExpression = "";

            // Фильтр по фамилии
            if (!string.IsNullOrEmpty(surnameTxtBox.Text))
            {
                filterExpression += $"(ФИО LIKE '%{surnameTxtBox.Text}%') AND ";
            }

            // Фильтр по статусу
            if (statusCmbBox.SelectedItem != null && !string.IsNullOrEmpty(statusCmbBox.SelectedItem.ToString()))
            {
                filterExpression += $"(Статус = '{statusCmbBox.SelectedItem}') AND ";
            }

            // Фильтр по отделу
            if (depCmbBox.SelectedItem != null && !string.IsNullOrEmpty(depCmbBox.SelectedItem.ToString()))
            {
                filterExpression += $"(Отдел = '{depCmbBox.SelectedItem}') AND ";
            }

            // Фильтр по должности
            if (postCmbBox.SelectedItem != null && !string.IsNullOrEmpty(postCmbBox.SelectedItem.ToString()))
            {
                filterExpression += $"(Должность = '{postCmbBox.SelectedItem}') AND ";
            }

            // Убираю последний "AND "
            if (filterExpression.EndsWith("AND "))
            {
                filterExpression = filterExpression.Remove(filterExpression.Length - 4);
            }

            // Применяю фильтр
            dt.DefaultView.RowFilter = filterExpression;
            personDgv.DataSource = dt.DefaultView;
        }

        //Кнопка для сброса фильтрации
        private void dropTxtBox_Click(object sender, System.EventArgs e)
        {
            // Сбрасываю все фильтры в ComboBox
            surnameTxtBox.Text = "";
            statusCmbBox.SelectedIndex = -1;
            depCmbBox.SelectedIndex = -1;
            postCmbBox.SelectedIndex = -1;
            
            //Очищаю строку для фильтрации
            dt.DefaultView.RowFilter = "";

            //Привожу DataGridView в первоначальный вид
            UpdateDgvPerson();
        }

        private void LoadFilterData()
        {
            using (TestTaskContext db = new TestTaskContext())
            {
                //Загружаю статусы в ComboBox
                var statuses = db.Statuses
                    .Select(s => s.Name)
                    .Distinct()
                    .ToList();

                statusCmbBox.Items.Clear();
                statusCmbBox.Items.AddRange(statuses.ToArray());

                //Загружаю отделы в ComboBox
                var departments = db.Deps
                    .Select(d => d.Name)
                    .Distinct()
                    .ToList();

                depCmbBox.Items.Clear();
                depCmbBox.Items.AddRange(departments.ToArray());

                //Загружаю статусы в должности
                var positions = db.Posts
                    .Select(p => p.Name)
                    .Distinct()
                    .ToList();

                postCmbBox.Items.Clear();
                postCmbBox.Items.AddRange(positions.ToArray());
            }
        }

        //Обновляю(загружаю данные в DataGridView
        private void UpdateDgvPerson()
        {
            using (TestTaskContext db = new TestTaskContext())
            {
                var persons = db.Persons
                    .Include(x => x.Status)
                    .Include(x => x.Dep)
                    .Include(x => x.Post)
                    .ToList();

                dt.Clear();

                foreach (var person in persons)
                {
                    DataRow row = dt.NewRow();
                    row["ФИО"] = $"{person.LastName} {person.FirstName[0]}. {person.SecondName[0]}.";
                    row["Статус"] = $"{person.Status.Name}";
                    row["Должность"] = $"{person.Post.Name}";
                    row["Отдел"] = $"{person.Dep.Name}";
                    row["Дата приема"] = person.DateEmploy;
                    row["Дата увольнения"] = person.DateUnemploy;
                    dt.Rows.Add(row);
                }

                personDgv.DataSource = dt;
            }
        }

        //Проверяю по какому способу проводится сортировка
        private void sortBtn_Click(object sender, System.EventArgs e)
        {
            //Сортировка по алфавиту
            if (sortUp.Checked)
            {
                personDgv.Sort(personDgv.Columns[0], ListSortDirection.Ascending);
            }
            else 
            //Сортировка в обратном порядке по алфавиту
            if (sortDown.Checked)
            {
                personDgv.Sort(personDgv.Columns[0], ListSortDirection.Descending);
            }
        }

        //Сбрасываю сортирвоку и привожу DataGridView в первоначальный вид
        private void dropSortBtn_Click(object sender, System.EventArgs e)
        {
            sortDown.Checked = false;
            sortUp.Checked = false;
            UpdateDgvPerson();
        }
    }
}