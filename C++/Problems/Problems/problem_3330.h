#ifndef PROBLEM_3330_H
#define PROBLEM_3330_H


#include "../problem.h"
#include <string>

class problem_3330 : public problem {
public:
    bool test() override;

    int possibleStringCount(std::string word);
};



#endif //PROBLEM_3330_H
