#ifndef PROBLEM_2075_H
#define PROBLEM_2075_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2075 : public problem {
public:
    bool test() override;

    std::string decodeCiphertext(std::string encodedText, int rows);
};

#endif //PROBLEM_2075_H
