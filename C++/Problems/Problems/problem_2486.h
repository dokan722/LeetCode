#ifndef PROBLEMS_PROBLEM_2486_H
#define PROBLEMS_PROBLEM_2486_H

#include "../problem.h"
#include <string>
#include <vector>



class problem_2486 : public problem {
public:
    bool test() override;

    int appendCharacters(std::string s, std::string t);
};

#endif //PROBLEMS_PROBLEM_2486_H