#ifndef PROBLEM_1860_H
#define PROBLEM_1860_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1860 : public problem {
public:
    bool test() override;

    std::vector<int> memLeak(int memory1, int memory2);
};

#endif //PROBLEM_1860_H
