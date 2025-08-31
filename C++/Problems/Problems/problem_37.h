#ifndef PROBLEM_37_H
#define PROBLEM_37_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_37 : public problem {
public:
    bool test() override;

    void solveSudoku(std::vector<std::vector<char>>& board);
private:
    bool solveSudokuRec(std::vector<std::vector<char>>& board, int x, int y);
    bool validate(std::vector<std::vector<char>>& board, int x, int y);
};



#endif //PROBLEM_37_H
