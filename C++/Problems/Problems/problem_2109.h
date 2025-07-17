#ifndef PROBLEM_2109_H
#define PROBLEM_2109_H

#include "../problem.h"
#include <vector>
#include <string>

class problem_2109 : public problem {
public:
    bool test() override;

    std::string addSpaces(std::string s, std::vector<int>& spaces);
};



#endif //PROBLEM_2109_H
