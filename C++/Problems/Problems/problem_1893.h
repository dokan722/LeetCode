#ifndef PROBLEM_1893_H
#define PROBLEM_1893_H


#include "../problem.h"
#include <vector>


class problem_1893 : public problem {
public:
    bool test() override;

    bool isCovered(std::vector<std::vector<int>>& ranges, int left, int right);
};



#endif //PROBLEM_1893_H
