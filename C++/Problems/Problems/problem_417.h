#ifndef PROBLEM_417_H
#define PROBLEM_417_H



#include "../problem.h"
#include <vector>


class problem_417 : public problem
{
public:
    bool test() override;

    std::vector<std::vector<int>> pacificAtlantic(std::vector<std::vector<int>>& heights);
private:
    void dfsCover(int i, int j, std::vector<std::vector<int>>& heights, std::vector<std::vector<bool>>& coverage);
};



#endif //PROBLEM_417_H
