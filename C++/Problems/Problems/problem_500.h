#ifndef PROBLEM_500_H
#define PROBLEM_500_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_500 : public problem {
public:
    bool test() override;

    std::vector<std::string> findWords(std::vector<std::string>& words);
};




#endif //PROBLEM_500_H
