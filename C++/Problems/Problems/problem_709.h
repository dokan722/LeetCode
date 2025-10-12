#ifndef PROLEM_709_H
#define PROLEM_709_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_709 : public problem {
public:
    bool test() override;

    std::string toLowerCase(std::string s);
};



#endif //PROLEM_709_H
