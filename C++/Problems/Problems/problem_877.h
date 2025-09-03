#ifndef PROBLEM_877_H
#define PROBLEM_877_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_877 : public problem {
public:
    bool test() override;

    bool stoneGame(std::vector<int>& piles);
private:
    int stoneGameRec(std::vector<int>& piles, std::vector<std::vector<int>>& dp, int i, int j, bool aliceTurn);
};



#endif //PROBLEM_877_H
