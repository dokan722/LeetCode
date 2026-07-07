#ifndef PROBLEM_1072_H
#define PROBLEM_1072_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_1072 : public problem {
public:
    bool test() override;

    int maxEqualRowsAfterFlips(std::vector<std::vector<int>>& matrix);
};


#endif //PROBLEM_1072_H
