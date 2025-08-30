#ifndef PROBLEM_36_H
#define PROBLEM_36_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_36 : public problem {
public:
    bool test() override;

    bool isValidSudoku(std::vector<std::vector<char>>& board);
};



#endif //PROBLEM_36_H
