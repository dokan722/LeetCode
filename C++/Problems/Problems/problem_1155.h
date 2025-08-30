#ifndef PROBLEM_1155_H
#define PROBLEM_1155_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1155 : public problem {
public:
    bool test() override;

    int numRollsToTarget(int n, int k, int target);
private:
    int NumRollsRec(int n, int k, int target, std::vector<std::vector<int>>& dp);
};



#endif //PROBLEM_1155_H
