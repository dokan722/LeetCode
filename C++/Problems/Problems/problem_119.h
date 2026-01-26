#ifndef PROBLEM_119_H
#define PROBLEM_119_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_119 : public problem {
public:
    bool test() override;

    std::vector<int> getRow(int rowIndex);
};

#endif //PROBLEM_119_H
