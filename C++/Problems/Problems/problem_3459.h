#ifndef PROBLEM_3459_H
#define PROBLEM_3459_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3459 : public problem {
public:
    bool test() override;

    int lenOfVDiagonal(std::vector<std::vector<int>>& grid);
private:
    int dfs(std::vector<std::vector<int>>& grid, std::vector<std::vector<int>>& dpWithTurn,
        std::vector<std::vector<int>>& dpNoTurn, int n, int m, int x, int y, int ver, int hor, int prev, bool haveMove);
};



#endif //PROBLEM_3459_H
