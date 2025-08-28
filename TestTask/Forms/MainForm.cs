using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            //Событие для выделения уволенного сотрудника
            personDgv.CellFormatting += PersonDgv_CellFormatting;

            personDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dt.Columns.Add("ФИО");
            dt.Columns.Add("Статус");
            dt.Columns.Add("Должность");
            dt.Columns.Add("Отдел");
            dt.Columns.Add("Дата приема");
            dt.Columns.Add("Дата увольнения");


            UpdateDgvPerson();
            LoadComboBox();
        }

        private void PersonDgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Для выделения ячейки в столбце ФИО ставлю условие, на этот столбец
            if (e.ColumnIndex == 0)
            {
                //Получаю значение статуса
                var statusValue = personDgv.Rows[e.RowIndex].Cells["Статус"].Value?.ToString();

                //Если статус сотрудника "Уволен" выделяю ячейку с ФИО красным цветом
                //При этом полученное значение ячейки перевожу в нижний регистр, в случае если значение в таблице содержится в другом регистре, как у меня
                if (statusValue.ToLower() == "уволен")
                {
                    e.CellStyle.BackColor = Color.IndianRed;
                }
            }
        }

        //Кнопка для применения фильтрации
        private void applyTxtBox_Click(object sender, System.EventArgs e)
        {
            //Создаю общую строку для фильтрации, чтобы не писать код для кажого ComboBox отдельно
            if (dt.Rows.Count == 0) return;

            string filterExpression = "";

            //Фильтр по фамилии
            if (!string.IsNullOrEmpty(surnameTxtBox.Text))
            {
                filterExpression += $"(ФИО LIKE '%{surnameTxtBox.Text}%') AND ";
            }

            //Фильтр по статусу
            if (statusCmbBox.SelectedItem != null && !string.IsNullOrEmpty(statusCmbBox.SelectedItem.ToString()))
            {
                filterExpression += $"(Статус = '{statusCmbBox.SelectedItem}') AND ";
            }

            //Фильтр по отделу
            if (depCmbBox.SelectedItem != null && !string.IsNullOrEmpty(depCmbBox.SelectedItem.ToString()))
            {
                filterExpression += $"(Отдел = '{depCmbBox.SelectedItem}') AND ";
            }

            //Фильтр по должности
            if (postCmbBox.SelectedItem != null && !string.IsNullOrEmpty(postCmbBox.SelectedItem.ToString()))
            {
                filterExpression += $"(Должность = '{postCmbBox.SelectedItem}') AND ";
            }

            //Убираю последний "AND "
            if (filterExpression.EndsWith("AND "))
            {
                filterExpression = filterExpression.Remove(filterExpression.Length - 4);
            }

            //Применяю фильтр
            dt.DefaultView.RowFilter = filterExpression;
            personDgv.DataSource = dt.DefaultView;
        }

        //Кнопка для сброса фильтрации
        private void dropTxtBox_Click(object sender, System.EventArgs e)
        {
            //Сбрасываю все фильтры в ComboBox
            surnameTxtBox.Text = "";
            statusCmbBox.SelectedIndex = -1;
            depCmbBox.SelectedIndex = -1;
            postCmbBox.SelectedIndex = -1;

            //Очищаю строку для фильтрации
            dt.DefaultView.RowFilter = "";

            //Привожу DataGridView в первоначальный вид
            UpdateDgvPerson();
        }

        private void LoadComboBox()
        {
            using (TestTaskContext db = new TestTaskContext())
            {
                //Загружаю статусы в ComboBox для вывода статистики
                var statusesForStat = db.Statuses
                    .Select(s => s.Name)
                    .Distinct()
                    .ToList();

                statusCmbBoxForStat.Items.AddRange(statusesForStat.ToArray());

                //Загружаю статусы в ComboBox
                var statuses = db.Statuses
                    .Select(s => s.Name)
                    .Distinct()
                    .ToList();

                statusCmbBox.Items.AddRange(statuses.ToArray());

                //Загружаю отделы в ComboBox
                var departments = db.Deps
                    .Select(d => d.Name)
                    .Distinct()
                    .ToList();

                depCmbBox.Items.AddRange(departments.ToArray());

                //Загружаю статусы в ComboBox
                var positions = db.Posts
                    .Select(p => p.Name)
                    .Distinct()
                    .ToList();

                postCmbBox.Items.AddRange(positions.ToArray());
            }
        }

        //Обновляю(загружаю данные в DataGridView)
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

        //Сбрасываю сортировку и привожу DataGridView в первоначальный вид
        private void dropSortBtn_Click(object sender, System.EventArgs e)
        {
            sortDown.Checked = false;
            sortUp.Checked = false;
            UpdateDgvPerson();
        }

        //Вывод статистики
        private void statBtn_Click(object sender, System.EventArgs e)
        {
            //Получаем все данные, которые ввел пользователь
            DateTime startPeriod = startDateTimePicker.Value.Date;
            DateTime endPeriod = endDateTimePicker.Value.Date;
            string status = statusCmbBoxForStat.Text;
            int counterDismissed = 0; //Счетчик уволеных людей
            int counterAll = 0; //Счетчик принятых людей

            if (startPeriod > endPeriod)
            {
                //Защита на случай неправильного ввода даты
                MessageBox.Show("Дата начала периода не может быть позже конца периода", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                
            foreach (DataGridViewRow row in personDgv.Rows)
                {
                    //Просмотр столбцов с датой увольнения
                    if (row.Cells[5].Value != null && DateTime.TryParse(row.Cells[5].Value.ToString(), out DateTime rowDateDismissed))
                    {
                        //Проверка подходит ли дата увольнения в указанный период
                        bool dateDismissed = rowDateDismissed.Date >= startPeriod && rowDateDismissed.Date <= endPeriod;
                        //Проверка подходит ли статус работника
                        bool statusPerson = row.Cells[1]?.Value?.ToString().ToLower() == "уволен";
                        if (dateDismissed && statusPerson)
                        {
                            counterDismissed++;
                            counterAll++;
                        }
                    }
                    //Просмотр столбцов с датой приема на работу
                    else if (row.Cells[4].Value != null && DateTime.TryParse(row.Cells[4].Value.ToString(), out DateTime rowDateWorker))
                    {
                        //Проверка подходит ли дата приема на работу в указанный период
                        bool dateWorker = rowDateWorker.Date >= startPeriod && rowDateWorker.Date <= endPeriod;
                        if (dateWorker)
                        {
                            counterAll++;
                        }
                    }
                }
            if (status.ToLower() == "уволен")
            {
                //Вывод статистики в случае, если выбран статус "Уволен"
                statisticsOutputLbl.Text = $"За период: {startPeriod:dd.MM.yyyy} - {endPeriod:dd.MM.yyyy} было уволено {counterDismissed} человек(-а).";

            }
            else if (status.ToLower() != "уволен")
            {
                //Вывод статистики в случае, если выбран статус "Работает", но в этот период все подходящие работники были уволены
                if (counterAll-counterDismissed < 0)
                {
                    statisticsOutputLbl.Text = $"За период: {startPeriod:dd.MM.yyyy} - {endPeriod:dd.MM.yyyy} на работу было принято  {counterAll} человек(-а). Из них работает 0 человек.";
                }
                //Вывод статистики в случае, если выбран статус "Работает", но в этот период не все подходящие работники были уволены
                else
                    statisticsOutputLbl.Text = $"За период: {startPeriod:dd.MM.yyyy} - {endPeriod:dd.MM.yyyy} на работу было принято  {counterAll} человек(-а). Из них работает {counterAll - counterDismissed} человек.";
            }
            //Сообщение в случае, если статус не был выбран
            else
            {
                MessageBox.Show("Вы не выбрали статус", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}