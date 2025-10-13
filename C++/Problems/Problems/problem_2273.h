#ifndef PROBLEM_2273_H
#define PROBLEM_2273_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2273 : public problem {
public:
    bool test() override;

    std::vector<std::string> removeAnagrams(std::vector<std::string>& words);
};



#endif //PROBLEM_2273_H
