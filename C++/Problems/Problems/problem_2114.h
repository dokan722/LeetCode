#ifndef PROBLEM_2114_H
#define PROBLEM_2114_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2114 : public problem {
public:
    bool test() override;

    int mostWordsFound(std::vector<std::string>& sentences);
};

#endif //PROBLEM_2114_H
