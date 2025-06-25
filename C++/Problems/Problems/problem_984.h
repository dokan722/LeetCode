//
// Created by peite on 25.06.2025.
//

#ifndef PROBLEM_984_H
#define PROBLEM_984_H

#include "../problem.h"
#include <string>

class problem_984 : public problem {
public:
    bool test() override;

    std::string strWithout3a3b(int a, int b);
};



#endif //PROBLEM_984_H
