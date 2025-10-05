#ifndef PROBLEM_49_H
#define PROBLEM_49_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_49 : public problem {
public:
    bool test() override;

    std::vector<std::vector<std::string>> groupAnagrams(std::vector<std::string>& strs);
};



#endif //PROBLEM_49_H
