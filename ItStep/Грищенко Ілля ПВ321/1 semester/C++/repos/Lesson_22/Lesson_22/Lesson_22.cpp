#pragma warning(disable:4996)
#include <iostream>
#include <cstring>
#define N 80
using namespace std;

class Student {
//private:
    char* initials{ nullptr };
    int birth_date[3];
    char contacts[15];
    char city[N];
    char country[N];
    char name_nz[N];
    int group_number;
public:
    Student()
    {
        initials = new char[8] {"No Name"};
        for (int i = 0; i < 3; ++i) birth_date[i] = 0;
        strcpy(contacts, "No contacts");
        strcpy(city, "No city");
        strcpy(country, "No country");
        strcpy(name_nz, "No NZ");
        group_number = 0;
    }
    Student(const char* name_nz,int group_number):group_number(group_number)
    {
        strcpy(this->name_nz, name_nz);
    }
    Student(const char* initials, const int* birth_date, const char* contacts, const char* city, const char* country, const char* name_nz, int group_number) :initials(new char[strlen(initials) + 1]), group_number(group_number)
    {
        strcpy(this->initials, initials);
        for (int i = 0; i < 3; ++i) this->birth_date[i] = birth_date[i];
        strcpy(this->contacts, contacts);
        strcpy(this->city, city);
        strcpy(this->country, country);
        strcpy(this->name_nz, name_nz);
    }
    ~Student()
    {
        if (initials != nullptr) delete[] initials;
    }

    inline void input()
    {
        cout << "Ініціали: ";
        char s[512];
        cin.getline(s, 512);

        initials = new char[strlen(s) + 1];
        strcpy(initials, s);

        cout << "Дата народженя(день, місяць, рік): ";
        cin >> birth_date[0] >> birth_date[1] >> birth_date[2];
        cin.ignore();
    
        cout << "Номер телефону: ";
        cin.getline(contacts, N);

        cout << "Місто: ";
        cin.getline(city, N);

        cout << "Країна: ";
        cin.getline(country, N);

        cout << "Навчальний заклад: ";
        cin.getline(name_nz, N);

        cout << "Номер групи: ";
        cin >> group_number;
        cin.ignore();

        cout << endl;
    }
    inline void show() const
    {
        cout << "Інформація:\n";
        cout << initials << endl << birth_date[0] << "." << birth_date[1] << "." << birth_date[2] << endl << contacts << endl;
        cout << city << endl << country << endl << name_nz << endl << group_number << endl << endl;
    }

    inline char* GetInitials() const
    {
        return initials;
    }
    inline void SetInitials(const char* new_initials)
    {
        if (initials != nullptr) delete[] initials;
        initials = new char[strlen(new_initials)+1];
        
    }

    inline const int* GetBirthDate() const
    {
        return birth_date;
    }
    inline void SetBirthDate(int* new_date)
    {
        birth_date[0] = new_date[0];
        birth_date[1] = new_date[1];
        birth_date[2] = new_date[2];

        delete[] new_date;
    }

    inline const char* GetContacnts() const
    {
        return contacts;
    }
    inline void SetContacnts(const char new_con[])
    {
        strcpy(contacts, new_con);
    }

    inline const char* GetCity() const
    {
        return city;
    }
    inline void SetCity(const char new_city[])
    {
        strcpy(city, new_city);
    }

    inline const char* GetCountry() const
    {
        return country;
    }
    inline void SetCountry(const char new_c[])
    {
        strcpy(country, new_c);
    }

    inline const char* GetNameNz() const
    {
        return name_nz;
    }
    inline void SetNameNz(const char new_name[])
    {
        strcpy(name_nz, new_name);
    }

    inline int GetGroupNumber() const
    {
        return group_number;
    }
    inline void SetGroupNumber(int new_number)
    {
        group_number = new_number;
    }
};

Student** NewArr(int size)
{
    Student** arr = new Student * [size] {nullptr};
    for (int i = 0; i < size; ++i) {
        cout << i + 1 << " студент:\n";
        arr[i] = new Student;
        arr[i]->input();
    }

    return arr;
}

void PrintArr(Student** arr, int size)
{
    for (int i = 0; i < size; ++i) {
        cout << i + 1 << ")\n";
        arr[i]->show();
    }
}

void DelArr(Student**& arr, int size)
{
    for (int i = 0; i < size; ++i) {
        delete[] arr[i];
    }

    delete[] arr;
}

void PrintUnder15(Student** arr, int size)
{
    for (int i = 0; i < size; ++i) {
        int age = 2023 - arr[i]->GetBirthDate()[2];
        if (age >= 15) {
            cout << i + 1 << ")\n";
            arr[i]->show();
        }
    }
}

int main()
{
    setlocale(0, "");

    int size;
    cout << "Введіть розмір: ";
    cin >> size;
    cin.ignore();

    cout << endl;

    Student** group = NewArr(size);
    PrintUnder15(group, size);
    DelArr(group, size);

    cout << endl;
    system("pause");
}