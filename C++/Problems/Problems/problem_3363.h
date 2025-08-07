#ifndef PROBLEM_3363_H
#define PROBLEM_3363_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3363 : public problem {
public:
    bool test() override;

    int maxCollectedFruits(std::vector<std::vector<int>>& fruits);
private:
    int checkLower(std::vector<std::vector<int>>& fruits, std::vector<std::vector<int>>& dp, int n, int x, int y, int k);
    int checkUpper(std::vector<std::vector<int>>& fruits, std::vector<std::vector<int>>& dp, int n, int x, int y, int k);
};



#endif //PROBLEM_3363_H
