#include <iostream>
using namespace std;

int main() {
    int br = 0;
    int i = 6;
    while (i <= 48) {
        cout << i << endl;
        br++;
        i += 6;
    }
    cout << "Ukupno je " << br << " brojeva." << endl;
}
