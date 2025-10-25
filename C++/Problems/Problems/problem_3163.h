#ifndef PROBLEM_3163_H
#define PROBLEM_3163_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3163 : public problem {
public:
    bool test() override;

    std::string compressedString(std::string word);
};



#endif //PROBLEM_3163_H
