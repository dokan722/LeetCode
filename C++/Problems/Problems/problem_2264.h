#ifndef PROBLEM2264_H
#define PROBLEM2264_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2264 : public problem {
public:
    bool test() override;

    std::string largestGoodInteger(std::string num);
};



#endif //PROBLEM2264_H
