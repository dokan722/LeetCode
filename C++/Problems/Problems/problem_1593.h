#ifndef PROBLEM_1593_H
#define PROBLEM_1593_H

#include "../problem.h"
#include <string>
#include <unordered_set>
#include <vector>

class problem_1593: public problem {
public:
    bool test() override;

    int maxUniqueSplit(std::string s);
private:
    int splitFurther(std::string s, std::string curr, int index, std::unordered_set<std::string>& present);
};



#endif //PROBLEM_1593_H
