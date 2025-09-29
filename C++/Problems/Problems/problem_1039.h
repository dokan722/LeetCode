#ifndef PROBLEM_1039_H
#define PROBLEM_1039_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1039: public problem {
public:
    bool test() override;

    int minScoreTriangulation(std::vector<int>& values);
private:
    int minScoreRec(int left, int right, std::vector<int>& values, std::vector<std::vector<int>>& dp);
};



#endif //PROBLEM_1039_H
