#ifndef PROBLEM_2115_H
#define PROBLEM_2115_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2115 : public problem {
public:
    bool test() override;

    std::vector<std::string> findAllRecipes(std::vector<std::string>& recipes, std::vector<std::vector<std::string>>& ingredients, std::vector<std::string>& supplies);
};



#endif //PROBLEM_2115_H
