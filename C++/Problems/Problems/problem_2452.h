#ifndef PROBLEM_2452_H
#define PROBLEM_2452_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2452 : public problem {
public:
    bool test() override;

    std::vector<std::string> twoEditWords(std::vector<std::string>& queries, std::vector<std::string>& dictionary);
};

#endif //PROBLEM_2452_H
