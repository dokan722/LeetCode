#ifndef PROBLEM_3838_H
#define PROBLEM_3838_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3838 : public problem {
public:
    bool test() override;

    std::string mapWordWeights(std::vector<std::string>& words, std::vector<int>& weights);
};

#endif //PROBLEM_3838_H
