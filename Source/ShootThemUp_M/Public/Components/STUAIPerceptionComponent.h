// Shoot Them Up Game, All Rights Reserved 

#pragma once

#include "CoreMinimal.h"
#include "Perception/AIPerceptionComponent.h"
#include "STUAIPerceptionComponent.generated.h"

/**
 * 
 */
UCLASS()
class SHOOTTHEMUP_M_API USTUAIPerceptionComponent : public UAIPerceptionComponent
{
	GENERATED_BODY()
	

public:
	AActor* GetClosestEnemy() const;
};
