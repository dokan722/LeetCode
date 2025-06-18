#ifndef PROBLEM_1356_H
#define PROBLEM_1356_H



#include "../problem.h"
#include <vector>


class problem_1356 : public problem {
public:
    bool test() override;

    std::vector<int> sortByBits(std::vector<int>& arr);
private:
    static bool compareBits(int &x, int &y);
};



#endif //PROBLEM_1356_H
