#ifndef PROBLEM_1562_H
#define PROBLEM_1562_H



#include "../problem.h"
#include <vector>


class problem_1562 : public problem {
public:
    bool test() override;

    int findLatestStep(std::vector<int>& arr, int m);
};



#endif //PROBLEM_1562_H
