#ifndef PROBLEM_118_H
#define PROBLEM_118_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_118 : public problem {
public:
    bool test() override;

    std::vector<std::vector<int>> generate(int numRows);
};



#endif //PROBLEM_118_H
