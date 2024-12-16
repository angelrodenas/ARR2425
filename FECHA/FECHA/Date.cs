
namespace FECHA
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;
        private int _hour;
        private int _minutos;
        private int _segundos;


        public Date (int year, int month, int day, int hour, int minutos, int segundos)
        {
            _segundos = segundos;
            fixSegundos();
            _minutos += minutos;
            fixMinutes();
            _hour += hour;
            fixHours();
            _day += day;
            fixDays();
            _month += month;
            fixMonths();
            _year += year;
        }
        private void fixSeconds()
        {
            int extraMinutes = _segundos / 60;
            _minutos = +extraMinutes;
            _segundos = _segundos / 60;
            fixMinutos();
        }
    }
}
