#ifndef PROBLEM_2545_H
#define PROBLEM_2545_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2545 : public problem {
public:
    bool test() override;

    std::vector<std::vector<int>> sortTheStudents(std::vector<std::vector<int>>& score, int k);
};



#endif //PROBLEM_2545_H
