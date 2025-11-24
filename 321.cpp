#include <iostream>

int main() {
    
    int arr[4][4];

    int value = 5;
    for (int i = 0; i < 4; i++) {
        for (int j = 0; j < 4; j++) {
            arr[i][j] = value;
            value += 5;
        }
    }

    std::cout << "Massiv 4x4:" << std::endl;
    for (int i = 0; i < 4; i++) {
        for (int j = 0; j < 4; j++) {
            std::cout << arr[i][j] << "\t";
        }
        std::cout << std::endl;
    }

    int sum = 0;
    for (int i = 0; i < 4; i++) {
        for (int j = 0; j < 4; j++) {
            sum += arr[i][j];
        }
    }

    std::cout << "Sum massiva: " << sum << std::endl;

    return 0;
}

