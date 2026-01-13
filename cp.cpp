#include <iostream>
using namespace std;

inline int square(int a) {
    return a * a;
}

inline int max(int a, int b) {
    return (a > b) ? a : b;
}

inline int abs(int a) {
    return (a < 0) ? -a : a;
}

inline bool ispositive(int a) {
    return a > 0;
}

inline int sum(int a, int b) {
    return a + b;
}

inline double average(double a, double b) {
    return (a + b) / 2.0;
}

inline bool iseven(int a) {
    return (a % 2) == 0;
}

inline int minthree(int a, int b, int c) {
    int minVal = a;
    if (b < minVal) minVal = b;
    if (c < minVal) minVal = c;
    return minVal;
}

inline double maxtwo(double a, double b) {
    return (a > b) ? a : b;
}

inline double perimeter(double width, double height) {
    return 2.0 * (width + height);
}

int main() {
    cout << "square(4) = " << square(4) << endl;
    cout << "max(3,7) = " << max(3, 7) << endl;
    cout << "abs(-5) = " << abs(-5) << endl;
    cout << "ispositive(10) = " << ispositive(10) << endl;
    cout << "sum(2,3) = " << sum(2, 3) << endl;

    cout << "average(2.5,3.5) = " << average(2.5, 3.5) << endl;
    cout << "iseven(4) = " << iseven(4) << endl;
    cout << "minthree(5,2,8) = " << minthree(5, 2, 8) << endl;
    cout << "maxtwo(1.1,2.2) = " << maxtwo(1.1, 2.2) << endl;
    cout << "perimeter(3,4) = " << perimeter(3.0, 4.0) << endl;

    return 0;
}
