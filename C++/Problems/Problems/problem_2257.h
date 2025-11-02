#ifndef PROBLEM_2257_H
#define PROBLEM_2257_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2257 : public problem {
public:
    bool test() override;

    int countUnguarded(int m, int n, std::vector<std::vector<int>>& guards, std::vector<std::vector<int>>& walls);
private:
    bool checkCell(int i, int j, bool state, std::vector<std::vector<int>>& prison);
};



#endif //PROBLEM_2257_H
