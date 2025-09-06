#ifndef PROBLEM_1807_H
#define PROBLEM_1807_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1807 : public problem {
public:
    bool test() override;

    std::string evaluate(std::string s, std::vector<std::vector<std::string>>& knowledge);
};



#endif //PROBLEM_1807_H
